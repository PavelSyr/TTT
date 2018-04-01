using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT.com.ich.UI
{
    public class TTTRowModel
    {
        private enum State { idle, started, paused };

        private State _State;

        private DateTime _CreatedAt;
        private DateTime _StartedAt;
        private DateTime _PausedAt;
        private TimeSpan _PauseSum;

        private TimeSpan _TimeDiff
        {
            get { return _PausedAt - _StartedAt - _PauseSum; }
        }

        public string CreatedAt { get { return _CreatedAt.ToShortTimeString(); } }
        public string StartedAt { get { return _StartedAt.ToShortTimeString(); } }
        public string PausedAt { get { return _PausedAt.ToShortTimeString(); } }
        public string TimeDiff
        {
            get
            {
                var d = _TimeDiff;
                return string.Format("{0}/{1}", d.ToString(@"hh\:mm"), d.TotalHours.ToString("0.00"));
            }
        }

        public double SpentTime { get { return _TimeDiff.TotalHours; } }

        public bool IsIdle { get { return _State == State.idle; } }
        public bool IsStarted { get { return _State == State.started; } }
        public bool IsPaused { get { return _State == State.paused; } }

        public event Action OnStarted;
        public event Action OnPaused;

        public TTTRowModel()
        {
            _CreatedAt = DateTime.Now;
            _PauseSum = new TimeSpan();
        }

        public void SwitchState()
        {
            State next = State.idle;
            switch (_State)
            {
                case State.idle:
                    next = State.started;
                    _StartedAt = DateTime.Now;
                    OnStarted?.Invoke();
                    break;
                case State.paused:
                    next = State.started;
                    _PauseSum += DateTime.Now - _PausedAt;
                    _PausedAt = new DateTime();
                    OnStarted?.Invoke();
                    break;
                case State.started:
                    next = State.paused;
                    _PausedAt = DateTime.Now;
                    OnPaused?.Invoke();
                    break;
            }

            _State = next;
        }
    }
}

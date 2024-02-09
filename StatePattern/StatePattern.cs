namespace StatePattern;
internal class StatePattern
{

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateC();
        }
    }
    public class ConcreteStateC : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
    public interface IState
    {
        void Handle(Context context);
    }

    public class Context
    {
        private IState _state;
        public Context(IState state)
        {
            _state = state;
        }

        public IState State
        {
            get { return _state; }
            set {
                _state = value;
                Console.WriteLine($"State: {_state.GetType().Name}");
            }
        }
        public void Request()
        {
            _state.Handle(this);
        }
    }
}

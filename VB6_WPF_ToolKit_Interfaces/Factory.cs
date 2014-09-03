namespace VB6_WPF_ToolKit_Interfaces
{
    public class Factory
    {
        public static readonly Factory Instance = new Factory();

        private IPlugIn _plugIn;

        public void DoSomething()
        {
            AssemblyLoader.LoadAssembly(".",this);
            _plugIn.DoSomething();
        }
    }
}

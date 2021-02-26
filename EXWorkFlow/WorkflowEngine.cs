namespace CsharpIntermediate
{
  public class WorkflowEngine
  {
    public void Run(IWorkFlow workflow)
    {
      workflow.Execute();
    }
  }
}
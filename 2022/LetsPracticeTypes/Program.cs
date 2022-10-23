public class DeploymentProcess : IDisposable
{
    bool disposed;

    readonly StreamWriter report = new StreamWriter("DeploymentReport.txt");

    public bool CheckStatus()
    {
        report.WriteLine($"{DateTime.Now} Application deployed.");

        return true;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            // disposal of purely managed resources goes here
        }

        report?.Close();
        disposed = true;
    }

    ~DeploymentProcess()
    {
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

static void Main(string[] args)
{
    using (var deployer = new DeploymentProcess())
    {
        deployer.CheckStatus();
    }
}

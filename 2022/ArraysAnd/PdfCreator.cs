public class PdfCreator
{
    private PdfDoc doc;

    public void Create(FileInfo outputFile)
    {
        doc = new PdfWriter(outputFile);
        Start();
    }

    public void Create(MemoryStream stream)
    {
        doc = new PdfWriter(stream);
        Start();
    }

    private void Start()
    {
        // Method1();
        Method1();
        Method2();
    }

    private void Method1()
    {

    }

    private void Method2()
    {

    }
}

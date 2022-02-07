namespace PEM.Models
{
    public enum ExportFormat : byte
    {
        //you need to learn about Enums.
        //Theyare used kinda like constants for when you have options.
        //Read about it on ms docs
        CSV,
        PDF
    }

  
    public enum ExportType //this needs a better name
    {
        Employee = 0,
        Summary
    }
    
}
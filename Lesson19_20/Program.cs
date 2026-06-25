namespace Lesson19_20;


// Event => delegate uzerinde qurulub, onun abstaction-dir


// Ferqleri ( Event vs Delegate ) 

// Event keyword - Delegate keyword

// 1. Event delegate uzerinde qurulub
// 2. Delegate parametr kimi istifade edilir, Event parament kimi istifade edilmir
// 3. Delegate interface daxilinde yazilmir, event-i yazam bilirik
// 4. Event = operatoru ile islemir

// Qeyd: Event Desktop app, Webform(aspx) app istifade edilir


delegate void Notify();

class Button
{
    public event Notify SizeChanged = null!;
    public event Notify MouseEnter = null!;
    public event Notify MouseLeave = null!;
    public event Notify MouseDoubleClick = null!;


    public string? Text { get; set; }
    public string? BackGroundColor { get; set; }
    public string? ForeGroundColor { get; set; }

    // Desctopda / Winformda bunlar olmur. OS terefinden idare edilir
    public void StartMouseEvents()
    {
        MouseEnter?.Invoke();
        MouseDoubleClick?.Invoke();
        MouseLeave?.Invoke();
    }

    public void StartSizeEvents()
    {
        SizeChanged?.Invoke();
    }

}






internal class Program
{
    static void Main(string[] args)
    {
        var button = new Button();

        button.MouseEnter += Button_MouseEnter;
        button.MouseDoubleClick += Button_MouseDoubleClick;
        button.SizeChanged += Button_SizeChanged;

        button.StartMouseEvents();
        button.StartSizeEvents();
    }

    private static void Button_SizeChanged()
    {
        Console.WriteLine("Button Size Changed");
    }

    private static void Button_MouseDoubleClick()
    {
        Console.WriteLine("Mouse Double clicked");
    }

    private static void Button_MouseEnter()
    {
        Console.WriteLine("Mouse clicked");
    }
}

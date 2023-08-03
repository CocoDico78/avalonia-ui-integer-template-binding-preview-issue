using Avalonia;
using Avalonia.Controls.Primitives;

namespace IntBindingPreviewIssue.Views;

public class TemplatedControl1 : TemplatedControl
{
    public static readonly StyledProperty<int> MyIntegerProperty = AvaloniaProperty.Register<TemplatedControl1, int>(nameof(MyInteger));

    public int MyInteger
    {
        get => GetValue(MyIntegerProperty);
        set => SetValue(MyIntegerProperty, value);
    }

    public static readonly StyledProperty<string> MyStringProperty = AvaloniaProperty.Register<TemplatedControl1, string>(nameof(MyString));

    public string MyString
    {
        get => GetValue(MyStringProperty);
        set => SetValue(MyStringProperty, value);
    }
}

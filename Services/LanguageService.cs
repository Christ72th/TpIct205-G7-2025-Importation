using System.Globalization;

namespace Deliberation.Services;

public class LanguageService
{
    public event Action? LanguageChanged;
    private CultureInfo _currentCulture = new("fr-FR");

    public CultureInfo CurrentCulture
    {
        get => _currentCulture;
        set
        {
            if (_currentCulture != value)
            {
                _currentCulture = value;
                LanguageChanged?.Invoke();
            }
        }
    }

    public void ToggleLanguage()
    {
        CurrentCulture = CurrentCulture.Name.StartsWith("fr") ? 
            new CultureInfo("en-US") : 
            new CultureInfo("fr-FR");
    }
}

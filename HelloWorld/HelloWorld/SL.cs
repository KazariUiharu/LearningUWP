using Windows.Storage;

public class SL
{
    public string LoadSetting(string key)
    {
        return ApplicationData.Current.LocalSettings.Values[key] == null ? string.Empty : ApplicationData.Current.LocalSettings.Values[key].ToString();
    }

    public void SaveSetting(string key, string value)
    {
        ApplicationData.Current.LocalSettings.Values[key] = value;
    }
}
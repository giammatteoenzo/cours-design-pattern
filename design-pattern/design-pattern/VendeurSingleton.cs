namespace design_pattern;

public class VendeurSingleton
{ 
    private static VendeurSingleton _instance = null;

    public static VendeurSingleton Instance()
    {
        if (_instance == null)
            _instance = new VendeurSingleton();
        return _instance;
    }
}
# EA Power Tools
This project is a Visual Studio 2015 project that adds some new features to Sparx System EA. In order to use this
project (until an installer is made) you will have to add a registry key and restart EA to see the addin appear. Basically the EA Addin process goes like this:

1. Create and Sign an Assembly Implementing The Proper COM Methods
2. Place It In The GAC
3. Add a registry entry so EA will load it.
4. Profit

There are two ways to install it:

1. Get the latest installer from [here](https://github.com/PlasmaTrout/EAPowerTools/raw/master/Output/EAPowerTools.exe)
2. Manually build the project in VS run as administrator and then manually add the registry key.

## REGISTRY
- To setup the registry, we need to start Regedit and find the ```HKEY_CURRENT_USER\Software\Sparx Systems\EAAddins``` directory.
- Add a new key with the name the same as your namespace. In our case it is EAPowerTools 
- The value for the key should be your project name followed by your entry point. 
- In our case the value would be: CS_AddinFramework.Main

## REGEDIT EXPORT
 [HKEY_CURRENT_USER\Software\Sparx Systems\EAAddins\EAPowerTools]
 @="EAPowerTools.Main"

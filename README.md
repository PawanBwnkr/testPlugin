
# react-native-smisdk-plugin

## Getting started

`$ npm install react-native-smisdk-plugin --save`

### Mostly automatic installation

`$ react-native link react-native-smisdk-plugin`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-smisdk-plugin` and add `RNSmisdkPlugin.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNSmisdkPlugin.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNSmisdkPluginPackage;` to the imports at the top of the file
  - Add `new RNSmisdkPluginPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-smisdk-plugin'
  	project(':react-native-smisdk-plugin').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-smisdk-plugin/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-smisdk-plugin')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNSmisdkPlugin.sln` in `node_modules/react-native-smisdk-plugin/windows/RNSmisdkPlugin.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Smisdk.Plugin.RNSmisdkPlugin;` to the usings at the top of the file
  - Add `new RNSmisdkPluginPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNSmisdkPlugin from 'react-native-smisdk-plugin';

// TODO: What to do with the module?
RNSmisdkPlugin;
```
  
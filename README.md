
# react-native-test-plugin

## Getting started

`$ npm install react-native-test-plugin --save`

### Mostly automatic installation

`$ react-native link react-native-test-plugin`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-test-plugin` and add `RNTestPlugin.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNTestPlugin.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNTestPluginPackage;` to the imports at the top of the file
  - Add `new RNTestPluginPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-test-plugin'
  	project(':react-native-test-plugin').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-test-plugin/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-test-plugin')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNTestPlugin.sln` in `node_modules/react-native-test-plugin/windows/RNTestPlugin.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Test.Plugin.RNTestPlugin;` to the usings at the top of the file
  - Add `new RNTestPluginPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNTestPlugin from 'react-native-test-plugin';

// TODO: What to do with the module?
RNTestPlugin;
```
  
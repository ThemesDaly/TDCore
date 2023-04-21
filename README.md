<h1 align="center">TDCore</h1>
<br><br>

## Description

**WHAT IS THIS FOR**

Good afternoon, everyone. This is my personal game kernel in which I collect useful implementations of various game features in one single architecture.

To implement hyper casual and hybrid projects.
<br><br><br><br><br>

## Roadmap

- [BaseControllers](#basecontrollers)
  - [MonoModule](#monomodule)
  - [MonoController](#monocontroller)
  
- [UI](#ui)
  - [UIController](#uicontroller)
  - [MonoWindow](#monowindow)
<br>  
  
##  <h2 align="center">BaseControllers</h2>
###  MonoModule
#### Example
```
namespace TDCore.BaseController

class PlayerController : MonoModule
{
   ...
}
```

- **void Instance()** 
- **void ManualUpdate()** 
- **void Destroy()** 
<br><h2 align="center"></h2>

### MonoController
#### Example
```
namespace TDCore.BaseController

class GameManager : MonoController
{
   ...
}
```

- **mode** enum(ManualUpdate, Update, FixedUpdate, LateUpdate)
- **void Instance()**
- **void AddModule(IModule module)**
- **void RemoveModule(IModule module)**
<br><h2 align="center"></h2>

## <h2 align="center">UI</h2>

 ### UIController
 #### Example
```
namespace TDCore.UI

class MyUI : UIController
{
     void Start()
     {
        Show<WindowGameplay>();
        Hide<WindowMenu>();
        //or
        Show<WindowGameplay>().Hide<WindowMenu>().Hide<WindowLoader>();
      }
}
```
 
- **void Instance()**
- **void Create(MonoWindow window)**
- **UIController Show<T>()**
- **UIController Hide<T>()**
- **T Get<T>()**
<br><h2 align="center"></h2>

 ### MonoWindow
 #### Example
```
namespace TDCore.UI

class WindowGameplay : MonoWindow
{
   ...
}
```
 
- **void Instance()**
- **void AddHeader(string name)**
- **void Show()**
- **void Hide()**

 - event onCompleted
 - event onShow
 - event onHide
<br><h2 align="center"></h2>

<h1 align="center">TDCore</h1>
<h2 align="center">

[![Mentioned in Awesome Vue.js](https://awesome.re/mentioned-badge.svg)](https://github.com/vuejs/awesome-vue)

</h2>

## Description

**WHAT IS THIS FOR**

Good afternoon, everyone. This is my personal game kernel in which I collect useful implementations of various game features in one single architecture.

To implement hyper casual and hybrid projects.

## How to use

###  MonoModule
#### Example
```
namespace TDCore.BaseController

class PlayerController : MonoModule
{
   ...
}
```

- **Instance()** 
- **Destroy()** 

### MonoController
#### Example
```
namespace TDCore.BaseController

class GameManager : MonoController
{
   ...
}
```

- **Instance()**
- **AddModule(IModule module)**
- **RemoveModule(IModule module)**
  
  
 ### MonoWindow
 #### Example
```
namespace TDCore.UI

class WindowGameplay : MonoWindow
{
   ...
}
```
 
- **Instance()**
- **AddHeader()**
- **Show()**
- **Hide()**

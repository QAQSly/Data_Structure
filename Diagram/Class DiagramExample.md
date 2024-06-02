# Class Diagram
``` mermaid
classDiagram
Animal <|-- Duck
Animal <|-- Fish
Animal <|-- Zebra
Animal : +int age
Animal : +String gender
Animal : +IsMammal()
Animal : + Mate()
class Duck{
    +String beakColor
    +Swim()
    +Quack()
}

class Fish{
    -int sizeInFeet
    -CanEat()
}

class Zebra{
    +bool is_wild
    +run()
}
```
## 定义类的方式
1. 通过关键字
``` mermaid
classDiagram
class Animal
Animal : +int age
Animal : +String gender
Animal : +Depost(int value)
Animal : +Mate() bool
```
2. 通过继承
``` mermaid
classDiagram
Animal~T~ <|-- Duck
```
## 定义关系
|类型|描述|
|---------|-------------------|
|`<\|--`|继承Inheritance|
|`*--`|组成Composition|
|`o--`|聚合Aggregation|
|`-->`|关联Association|
|`--`|链接（实心）Link (Solid)|
|`..>`|依赖Dependency|
|`..\|>`|实现Realization|
|`..`|链接（虚线）Link(Dashed)|
``` mermaid
classDiagram
classA <|-- classB : Inheritance
classC *-- classD : Composition
classE o-- classF : Aggregation
classG --> classH :  Association
classI -- classJ : Link(Solid)
classK ..> classL: Dependency
classO ..|> classP: Realization
classQ .. classR: Link(Dashed)
```
## 关系的唯一性 多样性
* 1
* 0 or 1
* 1 or * 一个或者更多
* * 许多
* n n{where n > 1}
* 0 to n {where n > 1}
* 1 to n {where n> 1}

``` mermaid
classDiagram
ClassA "1" --> "*" ClassB
Student "1" --> "1..*" Course
Galaxy --> "many" Star : Contains
```
## 类的注释
* <<Interface>> 表示接口类
* <<abstract>> 表示抽象类
* <<Service>> 表示服务类
* <<enumeration>> 表示枚举

* 在定义类的单独行动中
``` mermaid
classDiagram
class Shape
<<interface>> Shape
Shape : noOfVertices
Shape : Draw()
```
* 在嵌套格式中定义
``` mermaid
classDiagram
%% 这是一个枚举
class Color{
    <<enumeration>>
    Red
    Wihte
    Blue
    Black
}
```
## 交互
``` mermaid
classDiagram
class Shape
link Shape "https://www.github.com" "This a link"
class Shape1
click Shape1 href "https://www.github.com" "This a link for click"
class Shape3
callback Shape3 "callbackFunction" "This is a tooltip for a callback"
class Shape2
click Shape2 call callbackFunction() "This is a tooltip for a callback"
```
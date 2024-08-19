# 05 - Design Patterns

Example Diagrams

## Singleton

```mermaid
classDiagram
    class Singleton {
        -instance$ : Singleton
        +Instance$ : Singleton
        -Singleton()
        }
```
## Builder
```mermaid
classDiagram
    class Client {
    +Construct()
    }
    Client --> Builder : uses

    class Builder {
        <<abstract>>
        +Build()
    }

    class ConcreteBuilder {
        +BuildPart()
        +GetResult()
    }
    ConcreteBuilder --|> Builder :inherits
```

## Strategy
```mermaid
classDiagram
class Strategy {
 <<interface>>
 +Algorithm()
}

class Context {
    +Strategy : Strategy
    +DoSomething()
}

Context --> Strategy :uses

class Strategy1 {
    +Algorithm()
}
Strategy1 --|>  Strategy : implements

class Strategy2 {
    +Algorithm()
}
```
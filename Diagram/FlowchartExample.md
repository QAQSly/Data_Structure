# FlowchartExample
``` mermaid
flowchart TD
A[Start] --> B{Is it}
B --YES--> C[OK]
C --> D[Rethink]
D --> B
B --NO----> E[END]
```
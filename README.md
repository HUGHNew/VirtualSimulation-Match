## Todo

-   [x] 页面
    -   [x] 主页
    -   [x] 资料
    -   [x] 解剖
    -   [x] 意见
    -   [x] 问题【固定模板】
    -   [ ] 开始实验=资料+解剖+意见+[位置记录]+问题
        -   [x] 实验：描述+题 依次
        -   [x] 题目：选项在下方
-   [x] 逻辑
    -   [x] 多Form
    -   [x] Timer控制跳转 ~~Status记录窗口~~
    -   [x] 定点开窗口
    -   [x] Status的切换



### Status

Polling Timer轮询

根据OnStatus和Current判断

新增的页面更改需要

1.   **FormClosed** 事件
2.   **GetAvailableForm** 函数更改



## 资源文件

-   图片
    -   bg.png
    -   fight.png
-   内容(Resources)
    -   每个部分一个txt文件
    -   方便读取
    -   问题考虑用xml

-   问题描述(questions)
    -   直接使用富文本框
    -   使用rtf或者txt格式
    -   选项放在csv里面
        -   第一行为答案
        -   其余为选项


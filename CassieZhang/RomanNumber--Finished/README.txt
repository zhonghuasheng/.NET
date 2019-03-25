作业题目：Problem Three: Merchant's Guide to the Galaxy

开发环境：VS2017

运行环境：Windows10

操作步骤：
1. 使用VS2017打开RomanNumber.sln
2. 打开InputData.txt,输入你想计算的行，要计算的关键字必须在关键字“is”之后，“？”之前，并保存，例如(how much is pish tegj glob glob ?)
3. 右键“RomanNumber” project，点击rebuild，build成功之后，点击F5即可显示计算出的结果。


基本思路：
1.该题目有2点需要注意，一：能重复的字符最多只能重复3次；二：大字符必须排到小字符的前面，否则将减去小字符的值；
2.根据面向对象的思想，建立一个Roman类用来代表罗马字符，建立一个Product类用来代表题目中提到的Silver、Gold和Iron三类产品。
3.创建一个RomanHandler类用来处理罗马字符到数字的转换。
4.创建一个ProductHandler类用来根据product和product数量计算总价。
5.Util类用来处理InputData里面输入的文档，并解析出罗马字符和产品。
6.RomanComman类用来将罗马字符和对应的数组关联起来，然后组成基本的罗马对象集合
7.RomanNumberUnitTest project用Nunit来测试RomanNumber project中提供的公共方法



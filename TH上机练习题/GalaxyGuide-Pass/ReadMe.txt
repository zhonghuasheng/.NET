操作步骤：
1. 编译解决方案。
2. 在GalaxyGuide\Thoughtworks.Startup\bin\Debug目录下放入input.txt。
3. 执行Thoughtworks.Startup.exe文件，输出结果显示在控制台窗口上。

解题思路：
1. 从input.txt中逐行读出所有的内容。
2. 对每一行内容进行解析（问题解析，不规则字符解析，星际单位解析）。
3. 对两类问题进行输出（星际单位计算和不规则字符计算）。输出过程中需要进行阿拉伯数字转换，需要满足罗马字符和阿拉伯数字之间的转换规则，否则，显示error message或者问题无效。

UT：
只做了罗马字符与阿拉伯字符转换算法的详细UT。
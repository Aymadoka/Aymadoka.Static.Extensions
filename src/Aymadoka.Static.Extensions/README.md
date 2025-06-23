# 📦 C# 静态扩展库 - [Aymadoka.Static.Extensions](https://github.com/Aymadoka/Aymadoka.Static.Extensions)

> 简洁、实用、高效的 C# 扩展方法集合，涵盖时间、字符串、数组、哈希计算和序列化等常用功能。

## 🚀 简介

[Aymadoka.Static.Extensions](https://github.com/Aymadoka/Aymadoka.Static.Extensions) 是一个轻量级但功能强大的 C# 静态扩展库，为开发者提供了一组常用的扩展方法。通过这个库，您可以更轻松地处理日常开发中的常见任务，提升编码效率并减少重复代码。

无论是开发 Web 应用、桌面程序还是后端服务，本库都能无缝集成，助您写出更加优雅、可维护的代码。

## 🔧 主要功能

🕒 时间处理
* 格式化日期时间输出
* 计算两个时间之间的差异（天数、小时、分钟等）
* 快速加减时间单位（如添加几天、几小时）

📄 字符串操作
* 安全判断空值与空白字符
* 常用字符串替换、截取、拼接方法
* 支持 Base64 编码/解码

🧮 数组与集合
* 合并多个数组
* 判断数组是否为空或包含特定元素
* 转换为列表、排序、查找最大最小值等

🔐 哈希与加密
* 支持 MD5、SHA256、SHA512 等哈希算法
* 提供便捷的文件哈希校验方法

💾 序列化支持
* 快速将对象转换为 JSON / XML 字符串
* 反序列化 JSON / XML 字符串为对象
* 可选参数控制格式与缩进

## 📦 如何安装
使用 NuGet 包管理器安装：
```Bash
Install-Package Aymadoka.Static.Extensions
```

或者通过 .NET CLI 安装：
```Bash
dotnet add package Aymadoka.Static.Extensions
```

## 💡 使用示例

```Csharp
using Aymadoka.Static.HashExtension;
using Aymadoka.Static.SerializeExtension;

// 示例：获取字符串的 SHA256 哈希值
string hash = "Hello World".ToSHA256Hash();

// 示例：将对象序列化为 JSON
var user = new { Name = "Alice", Age = 30 };
string json = user.ToJson();
```

## 🌐 开源贡献
本项目是开源项目，欢迎任何贡献！
* ⭐️ 给项目点个 Star 表示支持！
* 🛠️ 提交 Issues 或 Pull Request 来改进项目。
* 📣 分享给更多人使用。

GitHub 地址：[前往 GitHub](https://github.com/Aymadoka/Aymadoka.Static.Extensions)

## 📬 联系我

如有问题或建议，请在 GitHub 上提交 Issue 或联系我：

📧 Email: aymadoka@foxmail.com
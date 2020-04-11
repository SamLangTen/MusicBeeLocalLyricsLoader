# MusicBee Local Lyrics Loader
增强MusicBee的本地歌词加载功能

## 使用方法

使用前请设置搜索路径和文件名匹配

可用的文件匹配项：

* % - 音乐文件所在目录（只用于搜索路径）
* {filename} - 文件名（不含扩展名）
* {title} - 歌曲标题
* {artist} - 艺术家
* {album} - 专辑

样例:

    标题：      Overfly -TV size ver.-
    专辑：      Overfly [DVD付期間限定盤 (アニメ盤)] 
    艺术家:     春奈るな
    文件名:     F:\Music Library\Anime\Sword Art Online\『ソードアート・オンライン』ED2テーマ「Overfly」\SECL-1223.flac

    搜索路径:       %, F:\Lyrics\
    文件名匹配:     {artist} - {title}, {filename}

插件会尝试加载以下文件

    F:\Music Library\Anime\Sword Art Online\『ソードアート・オンライン』ED2テーマ「Overfly」\春奈るな - Overfly -TV size ver.-.lrc

    F:\Music Library\Anime\Sword Art Online\『ソードアート・オンライン』ED2テーマ「Overfly」\SECL-1223.lrc

    F:\Lyrics\春奈るな - Overfly -TV size ver.-.lrc

    F:\Lyrics\SECL-1223.lrc

## 语言

设置面板支持以下语言:

* [English](./README.md)
* **Simplified Chinese**

语言会根据MusicBee的设置自动切换。




    
    

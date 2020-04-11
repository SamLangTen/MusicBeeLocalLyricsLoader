# MusicBee Local Lyrics Loader
Enable Musicbee to load lyrics from local filesystem

## Usage

Searching path and file pattern should be set for lyrics searching.

Available Patterns:

* % - Directory containing music file(available in searching path)
* {filename} - Filename without extension
* {title} - Title
* {artist} - Artist
* {album} - Album

Example:

    Title:      Overfly -TV size ver.-
    Album:      Overfly [DVD付期間限定盤 (アニメ盤)] 
    Artist:     春奈るな
    Filename:   F:\Music Library\Anime\Sword Art Online\『ソードアート・オンライン』ED2テーマ「Overfly」\SECL-1223.flac

    Searching Path: %, F:\Lyrics\
    File pattern:   {artist} - {title}.lrc, {filename}.lrc

Plugin will try to load these files:

    F:\Music Library\Anime\Sword Art Online\『ソードアート・オンライン』ED2テーマ「Overfly」\春奈るな - Overfly -TV size ver.-.lrc

    F:\Music Library\Anime\Sword Art Online\『ソードアート・オンライン』ED2テーマ「Overfly」\SECL-1223.lrc

    F:\Lyrics\春奈るな - Overfly -TV size ver.-.lrc

    F:\Lyrics\SECL-1223.lrc

## Language

This plugin support these language in config panel:

* **English**
* [Simplified Chinese](./README.zh-Hans.md)

Language will change according to language setting in MusicBee




    
    

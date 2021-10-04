# 🎵Music App

![Login Screen](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_25.png?raw=true)

## 💯The Goal of The Project💯
- Users (Premium and regular users) will listen to the song.
- A database will be developed for the music application. Desktop application will be implemented (Web and Mobile app is not required).
##  Description
 1. System; It consists of admin and users. admin; add songs, artists, albums, updates, performs deletion.
 2. Admin and user will log into the system with separate interfaces. Tables for server and user
will be created and powers will be determined.For example,the user's authority to add songs, add artists this authority will only be on the admin side.
 3. Admin; adding or deleting new artists, songs and albums will be able to. Song ID, Song Name, date, artist album, genre, duration, number of listens for the song, will have information. A song can have more than one artist. A song can only be in one album.
 4. For the artist, there will be ID, Artist name, Country information. Album information is; albumId, album name, should include artist, song, date, genre information. Multiple songs and multiple artists in one album can be found.
 5. Users can be Premium or regular members. Paid for premium must have information .

##  Scenario and Problems
### Problem 1: Each User Will Have Three Playlists (Pop-Jazz-Classic).
* When the user becomes a member of the system, three playlists will be created for that user.
* The user will be able to add the songs they want to these lists created as empty.
* Having three music genres in the database enough; Pop , Jazz, Classical.
### Problem 2 : Automatically Generated Lists Will be Displayed in The User Module.
* The number of listens will be kept for each song.
* The list of the 10 most listened songs according to the music genres (pop, jazz, classical), the list of the 10 most listened songs in general, the 10 most listened songs list by country should be presented to the user.
### Problem 3 :When Admin Performs Add - Delete - Update Operations on Tables, Related Tables Will Also be Updated.
* When a song is added-deleted-updated, that song needs to be added to all playlists, deleted and all playlists updated.
* The same procedures should be applied for the artist, album and other tables.

## Some Screenshot From the Project

![Regular User Login](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_1.png?raw=true)
![Regular user's Pop Jazz and Classic Playlist](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_2.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_3.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_4.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_5.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_6.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_7.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_8.png?raw=true)
![Premium User Login ](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_9.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_10.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_11.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_12.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_13.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_14.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_15.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_16.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_17.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_18.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_19.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_20.png?raw=true)
![](https://github.com/berkay-c/Music_App/blob/main/SS/Screenshot_21.png?raw=true)

## EER -Diagram
![](https://github.com/berkay-c/Music_App/blob/main/SS/Eer.png?raw=true)
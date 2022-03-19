# Slingshot

Docs em [Português](./README_pt-br.md).

Simple command line utility to organize your Tibia screenshots into sub-folders.

## What does this do?

Moves the screenshot images in the Tibia folder into sub-folders depending on the char's name and screenshot type.

Example of the results:

```text
Tibia Folder
|--- screenshots
|    |--- Aragorn
|    |    |--- Achievement
|    |    |--- BossDefeated
|    |    |    |--- 2021-03-24_181034186_Aragorn_BossDefeated.png       <-- Defeated the Nazgul
|    |    |--- DeathPvE
|    |    |--- LevelUp
|    |    |--- LowHealth
|    |    |--- SkillUp
|    |--- Gandalf
|    |    |--- Achievement
|    |    |    |--- 2021-09-11_201423412_Gandalf_Achievement.png        <-- New White Wizard outfit
|    |    |    |--- 2021-06-01_163617752_Gandalf_Achievement.png        <-- New Shadowfax mount
|    |    |--- BossDefeated
|    |    |    |--- 2021-09-11_201423412_Gandalf_BossDefeated.png       <-- Against the Balrog
|    |    |--- DeathPvE
|    |    |    |--- 2021-09-11_201423412_Gandalf_DeathPvE.png           <-- Against the Balrog
|    |    |--- Hotkey
|    |    |--- LevelUp
|    |    |--- LowHealth
|    |    |--- SkillUp
|    |--- Galadriel
|    |--- Frodo
|         |--- Achievement
|              |--- 2022-03-12_163115024_Frodo_Achievement.png          <-- New Eagle mount (service quest)
```

You can run it multiple times and will move any new screenshots to the sub-folders.
Note that IT WILL NOT move a file if there's already one with the same name.

## What this DOES NOT do?

> In absulutely NO CIRCUNSTANCES this program will directly transmit ANY data to the Internet and/or touch ANY files in your computer beyond the ones being mvoed into the sub-folders. 

> This program will not ask ANY information beyond the location of the Tibia screenshots folder. IT WILL NEVER ASK ANY PERSONAL INFORMATION OR ACCOUNT INFORMATION TO ACCESS THE GAME.

## How to use

- Download the zip file from the [releases page](https://github.com/hnrqbaggio/slingshot/releases).
- Right-click on the .zip file and then `Extract All...`
- Windows will ask where you want to extract the files. Any place is fine. Check the "shows files after extracting" option to open the folder.
- Right-click on `Slingshot.exe` and select `Send To` > `Desktop (Create Shortcut)`.

That's it, now you can just double click the shortcut in the Desktop when you want to organize your files.
It will open a window, show the progress of the copying operation (which might take a while the first time), say a nice message and exit.

## Help! It can't find the screenshots folder

You can customize the folder path by passing a parameter in the shortcut from the above steps.

- Find your Tibia screnshots folder.
  - The esiest way is to go to client's `Settings` > `Misc` > `Open Screenshots folder`.
  - Copy the path from the address bar.
- Right-click on the Desktop shortcut, then select Properties.
- Add the path to the screenshots folder to the `Target` field in the settings, between quotes.
- Hit OK and try to run the program again.

## Help! It's not finding any files to copy

Check out if Tibia is running. It might not let the app to access the files in that case.

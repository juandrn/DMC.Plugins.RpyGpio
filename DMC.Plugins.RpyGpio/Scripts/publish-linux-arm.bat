set output=bin\linux-arm

cd .. 

@rd /S /Q %output%
dotnet publish -c release -r linux-arm -o %output% 

@rd /S /Q  %output%\rwy
git clone https://github.com/juandrn/rpy.git %output%/temp
move %output%\temp\rwy %output%\rwy
@rd /S /Q %output%\temp

@rd /S /Q %output%\rwy\.git

cd %output%
7z a -tzip gpio.zip *


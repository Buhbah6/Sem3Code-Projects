#!/bin/bash

echo "" >> /home/bubsy/PlayTimes/recordedTimes.txt;
echo "ShutdownTime" >> /home/bubsy/PlayTimes/recordedTimes.txt;
echo | date >> /home/bubsy/PlayTimes/recordedTimes.txt;
python3 commit.py;

import sys
import datetime

def upload():
    videoPath = 'Video.mp4'
    os.mkdir('Videos')
    shutil.copy(videoPath, 'Videos')
    views = 0
    print("Views: " + "{}".format(views))
    open('views.txt', 'w').close()
    views = int(open('views.txt').read()) + 1
    open('views.txt', 'a').close()

import os
from git import Repo

PATH_OF_REPO = "/home/bubsy/PlayTimes"
COMMIT_MESSAGE = "Updated File"

def git_push():
    try:
        repo = Repo(PATH_OF_REPO)
        repo.git.add(update=True)
        repo.index.commit(COMMIT_MESSAGE)
        origin = repo.remote(name="origin")
        origin.push()
    except:
        print("Error when trying to push the changes")

git_push()
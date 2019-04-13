                                          Git
  
1. First go to specific folder in which you have to create git 
2.Right click & go to git bash
3.After opening git bash 
->git init {to start }
4.To create new file {suppose txt }
->notepad filename.txt
and then do changes & save the file
5.To add file
->git add .
it will add new repository
6.To check status
-> git status
it will show the status of your file.if it is in red then your file is not committed and if it is in green then 
7.To check logs
-> git log
it will show the logs of the changes done with time,date & hash value
8.To commit
->git commit -m "message"
git commit will commit your changes
and -m is use to to pass any message
9.to checkout
-> git checkout 4digit {4digit of hash file }
10.If you want to make head as your new local master
->git checkout -B master
11.Reflog
-> git reflog 
it wll give all logs & changes you have done 
12.To change head postion
->  git checkout HEAD@{2}
it will change head {here we have to add "2" whom did we want to change }

it will make head as file which you have checkout
10.To add in your cloud from local machine
->git remote -v
->git remote name{if you want} url
->git push name master
this command will push your file to your github from local machine
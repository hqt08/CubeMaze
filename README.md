CubeMaze
========

you are a ball in a freak'in crazy world

Add SSH Key for repository access
========

```bash
cd
ssh-keygen -t rsa -C "your_email@example.com"
cd ~/.ssh
cat ~/.ssh/id_rsa.pub
```

copy the contents of id_rsa.pub and add it to your ssh keys under settings in your account

Git Commands
========
For first time clone whole project:

```bash
git clone https://github.com/hqt08/CubeMaze.git
```

For pulling down any changes, and committing then pushing up your new changes:

```bash
git pull

git add your/new/files or for all: git add .

git commit -a -m "your new message"

git push
```

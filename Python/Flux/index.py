import random

# while

a, b = 0, 1

limit = 10000

while a < limit:
    if b > limit: 
        break
    print(b, end=" ")
    a, b = b, a + b


# for

db_names = list(("Mike", "Maria", "Helena", "John", "Matthieu", "Pedro", "Isaiah", "Marcos", "Gabriella"))
db_status = ("active", "inactive", "arquived")
users = {}

for name in db_names:
    users.__setitem__(name, db_status[random.randint(0, 2)])

print("\n\n {} \n".format(users))

for user, status in users.copy().items():
    if status == db_status[-2]:
        del users[user]

print("\n\n {} \n".format(users))
        


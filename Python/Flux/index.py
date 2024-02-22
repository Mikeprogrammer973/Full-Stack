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


# comando break

for number in range(2, 100):
    for x in range(2, number):
        if number % x == 0:
            print('{} equals {} * {}'.format(number, x , number // x))
            break
    else:
        print('{} is a prime number'.format(number))
       

# comando continue

for number in range(2, 20):
    if number % 2 == 0:
        print("Found an even number => {}".format(number))
        continue
    print("Found an odd number => {}".format(number))


# instrução match

def http_status_error(status):
    match status:
        case 400:
            return "Bad request"
        case 404: 
            return "Not found"
        case 345 | 897 | 345:
            return "Not allowed"
        case _:
            return "There's something wrong"

print(http_status_error(345), http_status_error(489), http_status_error(400), http_status_error(404))
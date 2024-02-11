
pets = ["cat", "dog", "rabbit"]

print(pets[-1])

pets.append("hamster")
pets.append("rat")
pets.append("fox")
pets.insert(0, "lion")

pets.pop()
pets.pop(0)
pets.remove("rat")

if "rat" not in pets:
    print("There's no rat here!")
    
print('There are {} pets.'.format(len(pets)))

animals = list(("zebra", "shark", "butterfly", "frog"))

animals.extend(pets)

print('\n\nThere are {} animals:\n'.format(len(animals)))

# for animal in animals:
#     print('- {}\n'.format(animal))

for i in range(len(animals)):
    print("\n{} => {} \n".format(i + 1, animals[i]))
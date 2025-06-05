import random

def generate_star_coordinates(filename, n_stars=10):
    with open(filename, 'w') as file:
        # Write header
        file.write("x,y,z\n")
        for _ in range(n_stars):
            # Generate random floats for x, y, z
            x = random.uniform(-1000, 1000)
            y = random.uniform(20, 1000)
            z = random.uniform(-1000, 1000)
            # Write line with 15 decimal places
            file.write(f"{x:.15f},{y:.15f},{z:.15f}\n")

if __name__ == "__main__":
    generate_star_coordinates("stars.txt", n_stars=5000)
    print("stars.txt file created with random star coordinates.")

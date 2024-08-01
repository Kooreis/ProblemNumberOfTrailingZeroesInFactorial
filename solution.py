def find_trailing_zeros(n):
    count = 0
    i = 5
    while n / i >= 1:
        count += int(n / i)
        i *= 5
    return int(count)

def main():
    num = int(input("Enter a number: "))
    print("Number of trailing zeros in", num, "factorial is", find_trailing_zeros(num))

if __name__ == "__main__":
    main()
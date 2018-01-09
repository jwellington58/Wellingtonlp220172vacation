def imc(a,p):
    return p / (a**2)

peso = float(input("Digite seu peso: "))
altura = float(input("Digite sua altura: "))
imc = imc(altura, peso)
if(imc < 17):
    print("Muito abaixo do peso\n")
elif(imc >= 17 and imc <= 18.49):
    print("Abaixo do peso\n")
elif(imc >= 18.5 and imc < 25):
    print("Peso normal\n")
elif(imc >= 25 and imc <30):
    print("Acima do peso\n")
elif(imc >= 30 and imc < 35):
    print("Obesidade I\n")
elif(imc >= 35 and imc < 40):
    print("Obesidade II\n")
else:
    print("Obesidade III\n")


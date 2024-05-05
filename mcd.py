import unittest

def mcd(a, b):
    """
    Calcula el máximo común divisor (MCD) de dos números.
    """
    while b:
        a, b = b, a % b
    return a

def mcd_cuatro_numeros(num1, num2, num3, num4):
    """
    Calcula el máximo común divisor (MCD) de cuatro números.
    """
    mcd1 = mcd(num1, num2)
    mcd2 = mcd(num3, num4)
    return mcd(mcd1, mcd2)

class TestMCD(unittest.TestCase):
    def test_mcd(self):
        # Pruebas para la función mcd
        self.assertEqual(mcd(12, 8), 4)
        self.assertEqual(mcd(17, 5), 1)
        self.assertEqual(mcd(30, 15), 15)
    
    def test_mcd_cuatro_numeros(self):
        # Pruebas para la función mcd_cuatro_numeros
        self.assertEqual(mcd_cuatro_numeros(12, 8, 30, 15), 1)
        self.assertEqual(mcd_cuatro_numeros(24, 36, 48, 60), 12)
        self.assertEqual(mcd_cuatro_numeros(18, 27, 36, 45), 9)  # Un ejemplo adicional

if __name__ == "__main__":
    unittest.main()
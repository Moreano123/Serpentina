import unittest
from Algoritmo2 import mcd

class MCDCuatroNumerosTest(unittest.TestCase):

    def test_mcd_cuatro_positivos(self):
        resultado = mcd(24, 36, 48, 60)
        self.assertEqual(resultado, 12)

    def test_mcd_con_un_negativo(self):
        resultado = mcd(24, 36, -48, 60)
        self.assertEqual(resultado, 12)

    def test_mcd_con_dos_negativos(self):
        resultado = mcd(-24, 36, -48, 60)
        self.assertEqual(resultado, 12)

    def test_mcd_con_tres_negativos(self):
        resultado = mcd(-24, -36, -48, 60)
        self.assertEqual(resultado, 12)

    def test_mcd_con_cuatro_negativos(self):
        resultado = mcd(-24, -36, -48, 60)
        self.assertEqual(resultado, 12)

    def test_mcd_con_cero(self):
        resultado = mcd(0, 24, 36, 48)
        self.assertEqual(resultado, 12)

    def test_mcd_con_todos_cero(self):
        resultado = mcd(0, 0, 0, 0)
        self.assertEqual(resultado, 0)

if __name__ == "__main__":
    unittest.main()

import unittest
import requests

ENDPOINT = "https://localhost:5001/api/loan/"


class LoanTests(unittest.TestCase):
    def test_something(self):
        # arrange
        amount = 45944

        # act
        response = requests.get(ENDPOINT + "GetAmountLoans", verify=False)

        # assert
        self.assertEqual(amount, int(response.content.decode()))


if __name__ == '__main__':
    unittest.main()

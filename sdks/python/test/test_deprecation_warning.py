import warnings
import unittest

from snaptrade_client.api_client import DeprecationWarningOnce


class RandomClass:
    @DeprecationWarningOnce
    def deprecated_method(self):
        return "Method called"

    @DeprecationWarningOnce(prefix="tag")
    def deprecated_method_with_prefix(self):
        return "Method with prefix called"


class TestDeprecationWarning(unittest.TestCase):
    def test_deprecation_warning_without_prefix(self):
        obj = RandomClass()

        with warnings.catch_warnings(record=True) as w:
            warnings.simplefilter("always")

            obj.deprecated_method()
            obj.deprecated_method()

            self.assertEqual(len(w), 1)
            self.assertTrue(issubclass(w[0].category, DeprecationWarning))
            self.assertNotIn("account_information", str(w[0].message))

    def test_deprecation_warning_with_prefix(self):
        obj = RandomClass()

        with warnings.catch_warnings(record=True) as w:
            warnings.simplefilter("always")

            obj.deprecated_method_with_prefix()
            obj.deprecated_method_with_prefix()

            self.assertEqual(len(w), 1)
            self.assertTrue(issubclass(w[0].category, DeprecationWarning))
            self.assertIn("tag", str(w[0].message))

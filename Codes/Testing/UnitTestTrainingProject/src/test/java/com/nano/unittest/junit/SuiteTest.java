package com.nano.unittest.junit;
import org.junit.runner.RunWith;
import org.junit.runners.Suite;

//Grup halinde verilen class'lara ait tum testleri sirasiyla calistirir.

@RunWith(Suite.class)
@Suite.SuiteClasses({
        AssertKolayTest.class,
        AssertTest.class,
        ParametreTest.class,
        YasamDongusuTest.class

})
public class SuiteTest {

}
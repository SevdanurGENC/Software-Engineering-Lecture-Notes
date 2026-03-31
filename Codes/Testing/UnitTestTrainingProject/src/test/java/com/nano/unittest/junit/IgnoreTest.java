package com.nano.unittest.junit;

import org.junit.Test;
import org.junit.Ignore;

public class IgnoreTest {
	@Test
	public void testMerhaba1() throws Exception {
		System.out.println("Merhaba 1");
	}

	@Test
	@Ignore("Bu metod ile ignore denendi.")
	public void testMerhaba2() throws Exception {
		System.out.println("Merhaba 2");
	}
}

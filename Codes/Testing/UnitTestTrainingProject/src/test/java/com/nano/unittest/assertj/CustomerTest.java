package com.nano.unittest.assertj;

import org.assertj.core.api.Condition;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static org.assertj.core.api.Assertions.*;

public class CustomerTest {
	
	List<String> turkSehirler = new ArrayList<String>(Arrays.asList("istanbul", "ankara", "izmir", "kastamonu"));
	List<String> yabanciSehirler = new ArrayList<String>(Arrays.asList("milano", "madrid", "barcelona", "londra"));

	@Test
	public void testStrings() throws Exception {
		String text1 = "istanbul";

		// akici method yapisiyla bircok eslestirmeyi pes pese yazabiliriz.
		assertThat(text1)
        .describedAs("bu bir hata")
        .isEqualTo("istanbul")
        .startsWith("is")
        .endsWith("l")
        .contains("tan")
        .isNotEmpty()
        .isNotNull()
        .doesNotContain("Sevdanur")
        .containsOnlyOnce("tan")
       ;
	}

	@Test
	public void testDuzListeler() throws Exception {

		List<String> sehirler = new ArrayList<String>(Arrays.asList("istanbul", "ankara", "izmir", "kastamonu"));

		assertThat(sehirler)
			.describedAs("bu bir hata ")
			.contains("ankara")
			.doesNotContain("bursa")
			.contains("istanbul", "ankara", "izmir", "kastamonu")
			.doesNotHaveDuplicates();

		// listemde sadece türk şehirleri olsun
		List<String> sehirler2 = new ArrayList<String>(Arrays.asList("istanbul", "ankara", "izmir", "kastamonu"));
		assertThat(sehirler2)
			.have(turkSehirler());

		// listemde sadece yabancı şehirleri olsun
		List<String> sehirlerler3 = new ArrayList<String>(Arrays.asList("milano", "madrid", "barcelona", "londra"));
		assertThat(sehirlerler3)
			.have(yabanciSehirler());

		// listemde sadece hem yabancı hem türk şehirleri olsun
		List<String> sehirler4 = new ArrayList<String>(Arrays.asList("istanbul", "ankara", "madrid", "barcelona", "londra"));
		assertThat(sehirler4)
			.haveExactly(2, turkSehirler()) // 2 tanesi bu koşula uyacak
			.haveExactly(3, yabanciSehirler()); // 3 tanesi bu koşula uyacak

	}

	private Condition<? super String> yabanciSehirler() {
		return new Condition<String>() {
			@Override
			public boolean matches(String s) {
				return yabanciSehirler.contains(s);
			}
		};
	}

	private Condition<? super String> turkSehirler() {
		return new Condition<String>() {
			@Override
			public boolean matches(String s) {
				return turkSehirler.contains(s);
			}
		}; 
	}
}

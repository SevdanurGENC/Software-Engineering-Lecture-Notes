# CodeCoverage
An example of using JaCoCo on about code coverage


![image](https://user-images.githubusercontent.com/5441882/148996985-edd50317-3fc2-4368-a200-69cbd04841d2.png)

![image](https://user-images.githubusercontent.com/5441882/148997020-f11ba9e0-de08-4959-95ca-1f1c14a1457f.png)

![image](https://user-images.githubusercontent.com/5441882/148997050-09fb84cd-1b66-4569-b28f-3017febeee55.png)

![image](https://user-images.githubusercontent.com/5441882/148997078-b1582fdf-e53e-4343-87a4-d523af0c6292.png)
 
```java
<build>
        <plugins>
            <plugin>
                <groupId>org.jacoco</groupId>
                <artifactId>jacoco-maven-plugin</artifactId>
                <version>0.7.9</version>
                <executions>
                    <execution>
                        <id>default-prepare-agent</id>
                        <goals>
                            <goal>prepare-agent</goal>
                        </goals>
                    </execution>
                    <execution>
                        <id>default-report</id>
                        <phase>prepare-package</phase>
                        <goals>
                            <goal>report</goal>
                        </goals>
                    </execution>
                    <execution>
                        <id>default-check</id>
                        <goals>
                            <goal>check</goal>
                        </goals>
                        <configuration>
                            <rules><!-- implementation is needed only for Maven 2 -->
                                <rule implementation="org.jacoco.maven.RuleConfiguration">
                                    <element>BUNDLE</element>
                                    <limits><!-- implementation is needed only for Maven 2 -->
                                        <limit implementation="org.jacoco.report.check.Limit">
                                            <counter>COMPLEXITY</counter>
                                            <value>COVEREDRATIO</value>
                                            <minimum>0.01</minimum>
                                        </limit>
                                    </limits>
                                </rule>
                            </rules>
                        </configuration>
                    </execution>
                </executions>
            </plugin>
            
        </plugins>
        </build>
```

![image](https://user-images.githubusercontent.com/5441882/149001304-93cde08f-759b-439d-8afa-789b9ffca9fc.png)

![image](https://user-images.githubusercontent.com/5441882/149001325-d0ee3549-1037-489b-9227-6f8ba829c1bc.png)

![image](https://user-images.githubusercontent.com/5441882/149001366-7eccf3e6-ba1d-4af3-b2bf-7e8ea752ffd0.png)

![image](https://user-images.githubusercontent.com/5441882/149001401-d5c178fa-3408-43f9-96c6-954bf63f048b.png)


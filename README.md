# RimAttest
RimAttest is an example web site for proving automated test tools and patterns.

##Goals

- Provide an example web site to give examples for WebInject test cases
- Simulate common test automation challenges, for example
    - waiting for data replication that may usually be very quick, but occasionally slow yet still within allowed tolerances
    - data replication where it replicates to some servers in the load balance much quicker than others
    - test environment stability issues
    - production environment stability issues that are so rare that they will not be fixed, yet somehow an automated test tool will invariably come across them
    - problems that only occur when running tests much quicker than a human could
    - dynamically named ids
    


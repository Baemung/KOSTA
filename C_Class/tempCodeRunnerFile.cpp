
    printf("a = %d = %08x\n", a, &a);
    printf("*Pa = %d = %08x\n\n", *Pa, Pa);
    
    a++;
    printf("a = %d = %08x\n", a, &a);
    printf("*Pa = %d = %08x\n\n", *Pa, Pa);
    
    vp = Pa++;
    printf("a = %d = %08x\n", a, &a);
    printf("*Pa = %d = %08x\n", *Pa, Pa);
    printf("*vp= %08x\n\n", vp);
    for(int i = 0; i < 5; i++){
        printf("%d\n", pArr[i]);
    }
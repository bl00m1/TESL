(println "hello world")
(print (* 2 (+ 2 2)) "\n")
(set x (+ "HLLO " "WRLD"))
(set y true)

(if
    (eq (not y) false)
    (exec
        (println "yo wasap"))
    (exec
        (println "beach")))


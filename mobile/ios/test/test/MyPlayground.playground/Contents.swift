import UIKit

// Este e o codigo principal do nosso projeto

/*
 sd
 sdf
 */

/*var nome = "churros"
 let felicidade: Int = 5
 let calorias: Double = 79.5
 let vegetal: Bool = false
 
 //func alimentoConsumido(){
 //    print("o alimento consumido foi: \(nome)")
 //}
 
 func alimentoConsumido(nome:String,caloria:Double){
 print("o alimento consumido foi: \(nome), com calorias: \(caloria)")
 }
 alimentoConsumido(nome: nome, caloria: calorias)*/

//let caloria1 = 50.5
//let caloria2 = 100
//let caloria3 = 300
//let caloria4 = 500
//
//let totalDeCalorias = [50.5, 100, 300, 500, 450]
//print(totalDeCalorias)

//for i in 0...3 {
//    print(i)
//    print(totalDeCalorias[i])
//}
//
//for i in 0...totalDeCalorias.count-1 {
//    print(i)
//    print(totalDeCalorias[i])
//}
//for caloria in totalDeCalorias {
//    print(caloria)
//}

//let totalDeCalorias = [50.5, 100]
//
//func todasCalorias(totalDeCalorias: [Double]) -> Double {
//    var total: Double = 0
//
//    for caloria in totalDeCalorias {
//        total += caloria
//    }
//    return total
//}
//
//let total = todasCalorias(totalDeCalorias: [50.5, 100, 400])
//
//print(total)

//classe
//class Refeicao{
//    var nome:String
//    var felicidade:String
//}

//let refeicao = Refeicao()
//refeicao.nome = "Arroz"
//
//// Cuidado => forced unwrap -- deve ser evitado
////print(refeicao.nome!)
//
//if refeicao.nome != nil{
////    print(refeicao.nome!)
//}
//
//// Boas práticas para extrair valores opcionais:
//if let nome = refeicao.nome{
////    print(nome)
//}
//
//// guard let
//func exibeNomeDaRefeicao(){
//    if let nome = refeicao.nome{
////        print(nome)
//    }
//
//    guard let nome = refeicao.nome else {
//        // ???
//        return
//    }
////    print(nome)
//}
//
////exibeNomeDaRefeicao()
//
//let numero = Int("5jdsakfjaskdj")
//
//if let n = numero{
//    print(n)
//}else{
//    print("erro ao converter string para int")
//}


//classe
class Refeicao{
    var nome:String
    var felicidade:String
    var itens:Array<Item>=[]
    
    init(nome:String, felicidade:String){
        self.nome = nome
        self.felicidade = felicidade
    }
    // MARK: // Metodos
    func totalDeCalorias() -> Double{
        var total = 0.0
        
        for item in itens{
            total += item.calorias
        }
        
        return total
    }
}


class Item{
    var nome:String
    var calorias:Double
    
    init(nome:String, calorias: Double) {
        self.nome=nome
        self.calorias = calorias
    }
}

let arroz = Item(nome: "Arroz", calorias: 51.0)
let feijao = Item(nome: "Feijão", calorias: 90.0)
let contraFile = Item(nome: "Contra Filé", calorias: 287.0)


let refeicao = Refeicao(nome: "Almoço", felicidade: "5")
refeicao.itens.append(arroz)
refeicao.itens.append(feijao)
refeicao.itens.append(contraFile)

print(refeicao.nome)
if let primeiroItemDaLista = refeicao.itens.first {
    print(primeiroItemDaLista.nome)
}

print(refeicao.totalDeCalorias())

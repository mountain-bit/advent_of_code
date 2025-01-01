#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <sstream>
#include <stdexcept>
#include <algorithm>

int main() {
    std::vector<std::string> line(1);

    try {
        std::ifstream file("tak.txt");
        if (!file.is_open()) {
            throw std::runtime_error("Nie mozna otworzyc pliku tak.txt");
        }
        std::string fileLine;
        if (std::getline(file, fileLine))
        {
            std::stringstream ss(fileLine);
            std::string word;
            line.clear();
            while (ss >> word)
            {
                line.push_back(word);
            }

            for (const std::string& str : line) {
                std::cout << str << std::endl;
            }
        }

        file.close();
        std::cin.get();
    }
    catch (const std::exception& e) {
        std::cerr << "Wyjatek: " << e.what() << std::endl;
    }

    std::vector<long long> kamienie;

    for (const std::string& str : line) {
        try {
            kamienie.push_back(std::stoll(str));
        }
        catch (const std::invalid_argument& e)
        {
            std::cerr << "Invalid argument: " << str << std::endl;
            return 1;
        }
    }

    std::cout << "----------------" << std::endl;

    int mrugniecia = 75;

    for (int i = 1; i <= mrugniecia; i++) {
        long long ile = kamienie.size();
        std::cout << "mrug " << i << " " << ile << std::endl;

        for (size_t j = 0; j < ile; j++) {
            if (kamienie[j] == 0) {
                kamienie[j] = 1;
            }
            else {
                std::string pom = std::to_string(kamienie[j]);
                if (pom.length() % 2 == 0)
                {
                    kamienie.push_back(std::stoll(pom.substr(0, pom.length() / 2)));
                    kamienie[j] = std::stoll(pom.substr(pom.length() / 2));
                }
                else {
                    kamienie[j] = kamienie[j] * 2024;
                }
            }
        }
        //for(long long x : kamienie)
        //{
          //  std::cout << x << " ";
        //}
        //std::cout << std::endl;
    }

    //for(long long x : kamienie)
    //{
        //std::cout << x << std::endl;
    //}
    std::cout << kamienie.size() << std::endl;

    return 0;
}
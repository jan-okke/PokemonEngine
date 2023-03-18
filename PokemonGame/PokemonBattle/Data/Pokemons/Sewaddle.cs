using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sewaddle : Pokemon
	{
		public override string Name => "Sewaddle";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(45, 53, 70, 40, 60, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Stringshot() },
			[8] = new List<Move>() { new Bugbite() },
			[15] = new List<Move>() { new Razorleaf() },
			[22] = new List<Move>() { new Strugglebug() },
			[29] = new List<Move>() { new Endure() },
			[31] = new List<Move>() { new Stickyweb() },
			[36] = new List<Move>() { new Bugbuzz() },
			[43] = new List<Move>() { new Flail() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bugbite(), new Calmmind(), new Confide(), new Cut(), new Doubleteam(), new Dreameater(), new Electroweb(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Irondefense(), new Lightscreen(), new Magiccoat(), new Naturepower(), new Payback(), new Protect(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Toxic(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Airslash(), new Batonpass(), new Camouflage(), new Grassyterrain(), new Mefirst(), new Mindreader(), new Razorwind(), new Screech(), new Silverwind() };
		public override int Weight => 25;
		public override int ExpYield => 62;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}
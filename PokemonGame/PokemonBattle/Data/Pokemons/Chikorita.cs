using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chikorita : Pokemon
	{
		public override string Name => "Chikorita";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(45, 49, 65, 49, 65, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[6] = new List<Move>() { new Razorleaf() },
			[9] = new List<Move>() { new Poisonpowder() },
			[12] = new List<Move>() { new Synthesis() },
			[17] = new List<Move>() { new Reflect() },
			[20] = new List<Move>() { new Magicalleaf() },
			[23] = new List<Move>() { new Naturepower() },
			[28] = new List<Move>() { new Sweetscent() },
			[31] = new List<Move>() { new Lightscreen() },
			[34] = new List<Move>() { new Bodyslam() },
			[39] = new List<Move>() { new Safeguard() },
			[42] = new List<Move>() { new Aromatherapy() },
			[45] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Echoedvoice(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Magiccoat(), new Naturepower(), new Protect(), new Reflect(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Workup(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Aromatherapy(), new Bodyslam(), new Counter(), new Flail(), new Grassyterrain(), new Healpulse(), new Ingrain(), new Leafstorm(), new Leechseed(), new Naturepower(), new Vinewhip() };
		public override int Weight => 64;
		public override int ExpYield => 64;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}
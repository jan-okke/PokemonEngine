using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Paras : Pokemon
	{
		public override string Name => "Paras";
		public override List<Ability> AvailableAbilities => new() {new Effectspore(), new Dryskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Damp() };
		public override Stats BaseStats => new Stats(35, 70, 55, 25, 45, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch() },
			[6] = new List<Move>() { new Stunspore(), new Poisonpowder() },
			[11] = new List<Move>() { new Absorb() },
			[17] = new List<Move>() { new Furycutter() },
			[22] = new List<Move>() { new Spore() },
			[27] = new List<Move>() { new Slash() },
			[33] = new List<Move>() { new Growth() },
			[38] = new List<Move>() { new Gigadrain() },
			[43] = new List<Move>() { new Aromatherapy() },
			[49] = new List<Move>() { new Ragepowder() },
			[54] = new List<Move>() { new Xscissor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Afteryou(), new Attract(), new Brickbreak(), new Bugbite(), new Bulletseed(), new Confide(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Falseswipe(), new Flash(), new Frustration(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Knockoff(), new Leechlife(), new Lightscreen(), new Naturepower(), new Protect(), new Rest(), new Return(), new Rocksmash(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Thief(), new Venoshock(), new Worryseed(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Bugbite(), new Counter(), new Crosspoison(), new Fellstinger(), new Flail(), new Grassyterrain(), new Leechseed(), new Metalclaw(), new Psybeam(), new Screech(), new Sweetscent(), new Wideguard() };
		public override int Weight => 54;
		public override int ExpYield => 57;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}
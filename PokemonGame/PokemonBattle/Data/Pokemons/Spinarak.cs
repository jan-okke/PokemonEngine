using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spinarak : Pokemon
	{
		public override string Name => "Spinarak";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Insomnia() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sniper() };
		public override Stats BaseStats => new Stats(40, 60, 40, 40, 40, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisonsting(), new Stringshot() },
			[5] = new List<Move>() { new Absorb() },
			[8] = new List<Move>() { new Infestation() },
			[12] = new List<Move>() { new Scaryface() },
			[15] = new List<Move>() { new Nightshade() },
			[19] = new List<Move>() { new Shadowsneak() },
			[22] = new List<Move>() { new Furyswipes() },
			[26] = new List<Move>() { new Suckerpunch() },
			[29] = new List<Move>() { new Leechlife() },
			[33] = new List<Move>() { new Agility() },
			[36] = new List<Move>() { new Pinmissile() },
			[40] = new List<Move>() { new Psychic() },
			[43] = new List<Move>() { new Poisonjab() },
			[47] = new List<Move>() { new Crosspoison() },
			[50] = new List<Move>() { new Stickyweb() },
			[54] = new List<Move>() { new Toxicthread() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Bugbite(), new Bugbuzz(), new Confide(), new Dig(), new Doubleteam(), new Electroweb(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Gigadrain(), new Hiddenpower(), new Infestation(), new Leechlife(), new Poisonjab(), new Protect(), new Psychic(), new Rest(), new Return(), new Round(), new Signalbeam(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Venoshock(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Batonpass(), new Disable(), new Lunge(), new Megahorn(), new Nightslash(), new Psybeam(), new Ragepowder(), new Toxicspikes() };
		public override int Weight => 85;
		public override int ExpYield => 50;
		public override int CatchRate => 255;
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
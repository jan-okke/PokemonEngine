using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cryogonal : Pokemon
	{
		public override string Name => "Cryogonal";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(80, 50, 50, 105, 95, 135);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bind(), new Iceshard() },
			[4] = new List<Move>() { new Confuseray() },
			[8] = new List<Move>() { new Rapidspin() },
			[12] = new List<Move>() { new Laserfocus() },
			[16] = new List<Move>() { new Icywind() },
			[20] = new List<Move>() { new Mist(), new Haze() },
			[24] = new List<Move>() { new Ancientpower() },
			[28] = new List<Move>() { new Aurorabeam() },
			[32] = new List<Move>() { new Slash(), new Nightslash() },
			[36] = new List<Move>() { new Freezedry() },
			[40] = new List<Move>() { new Lightscreen(), new Reflect() },
			[44] = new List<Move>() { new Recover() },
			[48] = new List<Move>() { new Icebeam() },
			[52] = new List<Move>() { new Acidarmor() },
			[56] = new List<Move>() { new Solarbeam() },
			[60] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Avalanche(), new Blizzard(), new Endure(), new Facade(), new Flashcannon(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Iciclespear(), new Icywind(), new Irondefense(), new Lightscreen(), new Poisonjab(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Round(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Tripleaxel() };
		public override int Weight => 1480;
		public override int ExpYield => 180;
		public override int CatchRate => 25;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}